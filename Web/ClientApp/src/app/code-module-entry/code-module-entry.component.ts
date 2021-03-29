import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
@Component({
  selector: 'app-code-module-entry',
  templateUrl: './code-module-entry.component.html',
  styleUrls: ['./code-module-entry.component.css']
})
export class CodeModuleEntryComponent implements OnInit {
  public id: number = -1;
  public codeItypeItem: any;
  constructor(private route: ActivatedRoute, private router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.id = +this.route.snapshot.paramMap.get("id")
  }

  ngOnInit() {

    this.http.get<any[]>(this.baseUrl + 'CodeManger/ModuleItem?id=' + this.id).subscribe(result => {
      console.log(result);
      if (result.length > 0) {
        this.codeItypeItem = result[0];
      } else {
        this.codeItypeItem = { id: 0, name: "", desc: "" };
      }

    }, error => console.error(error));




  }
  public save() {
    this.http.post<any>(this.baseUrl + 'CodeManger/ModuleEdit', this.codeItypeItem)
      .pipe(

      ).subscribe(s => {

      });
    alert("Saved!");
    this.router.navigate(['codeModule']);
  }

}
