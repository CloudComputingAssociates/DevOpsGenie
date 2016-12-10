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
//our root app component
const core_1 = require('@angular/core');
const platform_browser_1 = require('@angular/platform-browser');
const ng_bootstrap_1 = require('@ng-bootstrap/ng-bootstrap'); // ng bootstrap module
const resource_group_1 = require('./resource-group');
// Annotation section
let App = class App {
    constructor() {
    }
};
App = __decorate([
    core_1.Component({
        selector: 'app',
        template: `
    <div style="width: 50%; margin: 0 auto;">     
      <resource-group></resource-group>
    </div>
  `,
    }), 
    __metadata('design:paramtypes', [])
], App);
exports.App = App;
let AppModule = class AppModule {
};
AppModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            ng_bootstrap_1.NgbModule.forRoot()
        ],
        declarations: [
            App,
            resource_group_1.ResourceGroupComponent
        ],
        bootstrap: [App]
    }), 
    __metadata('design:paramtypes', [])
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.js.map