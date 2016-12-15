//our root app component
import { Component, NgModule } from '@angular/core';
import { HttpModule } from  '@angular/http';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';             // ng  bootstrap module

import { AppComponent } from './app.component';
import { ResourceGroupComponent } from './resource-group';

@NgModule({                              // root ng-module
  imports: [ BrowserModule, HttpModule, NgbModule.forRoot() ],
  declarations: [AppComponent, ResourceGroupComponent],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule {}
