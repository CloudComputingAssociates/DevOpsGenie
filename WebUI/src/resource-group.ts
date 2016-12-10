//resource-group component
import { Component } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs';

@Component({
    selector: 'resource-group',
    template: `<h3>
Resource Group ng2 component
    < /h3>

    < div >
    <button class="btn btn-default btn-lg"(click)="onClick()" id= "btnUserDetails" > CALL REST API< /button>
    < p >
    </div>
    < div >
    <table border="1" bordercolor= "white" >
    <tr>
    Resource Groups
        </tr >
    <tr *ngFor="let rg of resourcegroups" >

    <td><span>{{rg.resourcegroup }}</span></td>
    </tr>
    < /table>
    </div>
`
})
// Component controller
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