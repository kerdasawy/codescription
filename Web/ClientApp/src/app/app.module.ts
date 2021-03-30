import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { DataTablesModule } from "angular-datatables";

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CodeListComponent } from './code-list/code-list.component';
import { CodeTypeListComponent } from './code-type-list/code-type-list.component';
import { CodeTypeEntryComponent } from './code-type-entry/code-type-entry.component';
import { CodeComponentEntryComponent } from './code-component-entry/code-component-entry.component';
import { CodeModuleEntryComponent } from './code-module-entry/code-module-entry.component';
import { CodeModuleListComponent } from './code-module-list/code-module-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CodeListComponent,
    CodeTypeListComponent,
    CodeTypeEntryComponent,
    CodeComponentEntryComponent,
    CodeModuleEntryComponent,
    CodeModuleListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    DataTablesModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: CodeListComponent, pathMatch: 'full' },
      { path: 'codeEntry', component: CodeComponentEntryComponent },
      { path: 'codeEntry/:id', component: CodeComponentEntryComponent },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'codeTypes', component: CodeTypeListComponent },
      { path: 'codeTypesEntry/:id', component: CodeTypeEntryComponent},
       { path: 'codeTypesEntry', component: CodeTypeEntryComponent },
      { path: 'codeModule', component: CodeModuleListComponent },
      { path: 'codeModuleEntry/:id', component: CodeModuleEntryComponent },
      { path: 'codeModuleEntry', component: CodeModuleEntryComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
