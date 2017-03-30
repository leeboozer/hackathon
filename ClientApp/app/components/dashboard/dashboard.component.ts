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
    public selectedClientId: number;
    public volPools: VolPool[];
    private http: Http;

    constructor(http: Http) {
        this.http = http;

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

    clientChanged() {
        this.volPools = new Array<VolPool>();

        let url = '/api/VolunteerPoolCalc/' + this.selectedClientId;
        console.log(url);   //LVBBUG
        this.http.get(url)
            .subscribe(results => {
                //console.log(results.json());      //LVBBUG
                for (let result of results.json()) {
                    let volPool = new VolPool();
                    volPool.candidateId = result.candidateId;
                    volPool.lastName = result.lastName;
                    volPool.firstName = result.firstName;
                    volPool.status = result.status;
                    this.volPools.push(volPool);
                }
            });
    }

}

export class Client {
    clientId: number;
    accountName: string;
}

export class VolPool {
    candidateId: number;
    lastName: string;
    firstName: string;
    status: string;
}
