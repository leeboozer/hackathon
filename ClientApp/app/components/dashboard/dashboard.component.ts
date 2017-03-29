import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'dashboard',
    templateUrl: './dashboard.component.html'
})
export class DashboardComponent {
    public clients: Client[];

    constructor(http: Http) {
        http.get('/api/Client').subscribe(result => {
            this.clients = result.json() as Client[];
        });
    }
}

interface Client {
    clientId: number;
    accountName: string;
}