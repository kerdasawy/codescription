import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-code-type-entry',
  templateUrl: './code-type-entry.component.html',
  styleUrls: ['./code-type-entry.component.css']
})
export class CodeTypeEntryComponent implements OnInit {

  public id: number = -1;
  private codeItypeItem: any;
  constructor(private route: ActivatedRoute, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.id = +this.route.snapshot.paramMap.get("id")
  }

  ngOnInit() {
     
    this.http.get<any[]>(this.baseUrl + 'CodeManger/CodeTypeItem?id=' + this.id).subscribe(result => {
      console.log(result);
      if (result.length>0) {
        this.codeItypeItem = result[0];
      }
        
      }, error => console.error(error));

    
   

  }

  public save() {
    this.http.post<any>(this.baseUrl + 'CodeManger/CodeTypeEdit',  this.codeItypeItem   )
      .pipe(

      ).subscribe(s => {

      });
  }

}
