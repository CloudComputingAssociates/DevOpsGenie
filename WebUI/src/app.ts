//our root app component
import {Component, NgModule} from '@angular/core'
import {BrowserModule} from '@angular/platform-browser'
import { 
  HttpModule, 
  Http, 
  Response
} from '@angular/http';

import { Observable } from 'rxjs';

// Annotation section
@Component({
  selector: 'my-app',
  template: `
    <div style="width: 50%; margin: 0 auto;">     
      <user-selector></user-selector>
    </div>
  `,  
})
// Component controller
export class App { 
  constructor() { }
}

// Annotation section
@Component({
  selector: 'user-selector',
  templateUrl: 'user-information-apps.html'
})

// Component controller
export class UserInformation {

  resourcegroups:Observable<Array<any>>;
  url: string;

  constructor(private _http: Http) {  
      this.url ='http://dogservice.azurewebsites.net/api/azure/resourcegroups';
  } //end constructor 

onClick(){	
	this._http.get(this.url)
          .subscribe((res: Response) => {
              this.resourcegroups = res.json();
          }); 
    } 
}

@NgModule({
  imports: [ 
    BrowserModule, 
    HttpModule 
  ],
  declarations: [ App,UserInformation ],
  bootstrap: [ App ]
})
export class AppModule {}