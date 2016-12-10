"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
//resource-group component
const core_1 = require('@angular/core');
const http_1 = require('@angular/http');
let ResourceGroupComponent = class ResourceGroupComponent {
    constructor(_http) {
        this._http = _http;
        this.url = 'http://dogservice.azurewebsites.net/api/azure/resourcegroups';
    } //end constructor 
    onClick() {
        this._http.get(this.url) // getting the json back   TODO: should this be in a provider
            .subscribe((res) => {
            this.resourcegroups = res.json();
        });
    }
};
ResourceGroupComponent = __decorate([
    core_1.Component({
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
    }), 
    __metadata('design:paramtypes', [http_1.Http])
], ResourceGroupComponent);
exports.ResourceGroupComponent = ResourceGroupComponent;
//# sourceMappingURL=resource-group.js.map