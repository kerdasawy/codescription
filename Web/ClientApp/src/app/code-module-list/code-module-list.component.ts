
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-code-module-list',
  templateUrl: './code-module-list.component.html',
  styleUrls: ['./code-module-list.component.css']
})
export class CodeModuleListComponent   {
  public codeData: any[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any[]>(baseUrl + 'CodeManger/ModuleList').subscribe(result => {
      console.debug("data received");
      console.debug(result);
      this.codeData = result;
      console.debug("data:" + this.codeData.length);
    }, error => console.error(error));
  }

 
}
