 
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-code-list',
  templateUrl: './code-list.component.html',
  styleUrls: ['./code-list.component.css']
})
export class CodeListComponent   {
  public codeData: CodeData[];
  public dtOptions: DataTables.Settings = {};
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    http.get<CodeData[]>(baseUrl + 'CodeManger/List').subscribe(result => {
      console.debug("datareviced");
      console.debug(result);
      this.codeData = result;
      console.debug("data:" + this.codeData.length);
    }, error => console.error(error));

    this.dtOptions = {
      pagingType: 'full_numbers', pageLength: 50
    };
  }

   

}

export class CodeData {
  Code: string; Type: string; Moudel: string; Message: string; Desc: string; Color: string;
}
 

