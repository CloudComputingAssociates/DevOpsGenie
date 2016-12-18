//main entry point
import {platformBrowserDynamic} from '@angular/platform-browser-dynamic';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppModule } from './src/app-ng.module.js';

platformBrowserDynamic().bootstrapModule(AppModule)
  .then(success => console.log('Bootstrap success'))
  .catch(err => console.error(err));
