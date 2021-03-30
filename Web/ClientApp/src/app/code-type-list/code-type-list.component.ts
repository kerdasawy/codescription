 
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-code-type-list',
  templateUrl: './code-type-list.component.html',
  styleUrls: ['./code-type-list.component.css']
})
export class CodeTypeListComponent {
  public codeData: CodeTypeData[];
  public dtOptions: DataTables.Settings = {};
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

    this.LoadData(this.http, this.baseUrl);

    this.dtOptions = {
      pagingType: 'full_numbers', pageLength:50
    };
  }
  private LoadData(http: HttpClient, baseUrl: string) {
    http.get<any[]>(baseUrl + 'CodeManger/CodeTypeList').subscribe(result => {
      console.debug("data received");
      console.debug(result);
      this.codeData = result;
      console.debug("data:" + this.codeData.length);
    }, error => console.error(error));
  }
  public delete(id): void {

    this.http.get<any[]>(this.baseUrl + 'CodeManger/CodeTypeItemDelete?id=' + id).subscribe(result => {
      console.debug("data received");
      alert("Deleted");

    }, error => alert("Not Deleted may be used by code item(s)"), () => { alert("Deleted"); this.LoadData(this.http, this.baseUrl); });
  }

}

export class CodeTypeData {
  public id: number;
  public name: string;
  public desc: string;
  public color: string;


}
