
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-code-module-list',
  templateUrl: './code-module-list.component.html',
  styleUrls: ['./code-module-list.component.css']
})
export class CodeModuleListComponent   {
  public codeData: any[];
  
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    
    this.LoadData(http, baseUrl);
  }

  private LoadData(http: HttpClient, baseUrl: string) {
        http.get<any[]>(baseUrl + 'CodeManger/ModuleList').subscribe(result => {
            console.debug("data received");
            console.debug(result);
            this.codeData = result;
            console.debug("data:" + this.codeData.length);
        }, error => console.error(error));
    }

  public delete( id): void {
 
    this.http.get<any[]>(this.baseUrl + 'CodeManger/ModuleItemDelete?id='+id).subscribe(result => {
      console.debug("data received"); 
      alert("Deleted");
     
    }, error => alert("Not Deleted may be used by code item(s)"), () => { alert("Deleted");  this.LoadData(this.http, this.baseUrl); });
  }
}
