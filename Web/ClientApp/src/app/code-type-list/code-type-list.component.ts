 
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-code-type-list',
  templateUrl: './code-type-list.component.html',
  styleUrls: ['./code-type-list.component.css']
})
export class CodeTypeListComponent {
  public codeData: CodeTypeData[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    http.get<CodeTypeData[]>(baseUrl + 'CodeManger/CodeTypeList').subscribe(result => {
      console.debug("data received");
      console.debug(result);
      this.codeData = result;
      console.debug("data:" + this.codeData.length);
    }, error => console.error(error));
  }



}

export class CodeTypeData {
  public id: number;
  public name: string;
  public desc: string;
  public color: string;


}
