//our root app component
import { Component, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';             // ng  bootstrap module

import { ResourceGroupComponent } from './resource-group';

@NgModule({                             // root ng-module
  imports: [ BrowserModule, NgbModule.forRoot() ],
  declarations: [ ResourceGroupComponent ],
  bootstrap: [ ResourceGroupComponent ]
})
export class AppModule {}
