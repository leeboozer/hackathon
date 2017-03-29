import { Component, Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from "rxjs/Rx";
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

@Component({
    selector: 'dashboard',
    templateUrl: './dashboard.component.html'
})

export class DashboardComponent {

    public clients: Client[];

    constructor(http: Http) {
        this.clients = new Array<Client>();

        http.get('/api/Client/GetAll')
            .subscribe(results => {
                for (let result of results.json()) {
                    let client = new Client();
                    client.clientId = result.clientId;
                    client.accountName = result.accountName;
                    this.clients.push(client);
                }
            });
    }

}

export class Client {
    clientId: number;
    accountName: string;
}
