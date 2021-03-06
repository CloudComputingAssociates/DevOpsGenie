﻿//resource-group component
import { Component } from '@angular/core';
import { HttpModule, Http, Response } from '@angular/http';
import { Observable } from 'rxjs';

@Component({
    selector: 'resource-group',
    templateUrl:  'src/resource-group.html'
})
export class ResourceGroupComponent {

    resourcegroups: Observable<Array<any>>;
    url: string;

    constructor(private _http: Http) {                    // injection of Http service
        this.url = 'http://dogservice.azurewebsites.net/api/azure/resourcegroups';
    } //end constructor

    onClick() {
        this._http.get(this.url)                            // getting the json back   TODO: should this be in a provider
            .subscribe((res: Response) => {
                this.resourcegroups = res.json();
            });
    }
}
