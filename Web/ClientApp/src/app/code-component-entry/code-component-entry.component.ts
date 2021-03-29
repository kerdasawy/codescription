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
  constructor(private route: ActivatedRoute, private router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
  }

}
