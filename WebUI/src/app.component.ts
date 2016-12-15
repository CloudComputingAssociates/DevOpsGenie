import { Component } from '@angular/core';
import { ResourceGroupComponent } from './resource-group';

@Component({
  selector: 'my-app',
  template: `<resource-group></resource-group>`
})
export class AppComponent {
  name = 'Angular';
  error: string; }
