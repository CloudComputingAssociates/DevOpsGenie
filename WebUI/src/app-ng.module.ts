//our root app component
import { Component, NgModule } from '@angular/core';
import { HttpModule } from  '@angular/http';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';             // ng  bootstrap module

import { AppComponent } from './app.component';
import { ResourceGroupComponent } from './resource-group';

@NgModule({                              // root ng-module
  imports: [ BrowserModule, HttpModule, NgbModule.forRoot() ],
  declarations: [AppComponent, ResourceGroupComponent],
  bootstrap: [AppComponent]
})
export class AppModule {}
