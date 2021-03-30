import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-code-component-entry',
  templateUrl: './code-component-entry.component.html',
  styleUrls: ['./code-component-entry.component.css']
})
export class CodeComponentEntryComponent implements OnInit {
  public id: number = -1;
  public codeItem: any;
  public codeTypesList: any[];
  public moudlesList: any[];
  constructor(private route: ActivatedRoute, private router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.id = +this.route.snapshot.paramMap.get("id")

    http.get<any[]>(baseUrl + 'CodeManger/ModuleList').subscribe(result => {
      this.moudlesList = result;
    }, error => console.error(error), () => {
      http.get<any[]>(baseUrl + 'CodeManger/CodeTypeList').subscribe(result => {
        this.codeTypesList = result;
      }, error => console.error(error));
    });
    this.http.get<any[]>(this.baseUrl + 'CodeManger/CodeItem?id=' + this.id).subscribe(result => {
      console.log(result);
      if (result.length > 0) {
        this.codeItem = result[0];
      } else {
        this.codeItem = { id: 0, name: "", desc: "" };
      }

    }, error => console.error(error),  );

  }

  ngOnInit() {
  }


  public save() {
    this.http.post<any>(this.baseUrl + 'CodeManger/CodeItemEdit', this.codeItem)
      .pipe(

      ).subscribe(s => {

      });
    alert("Saved!");
    this.router.navigate(['/']);
  }

}
