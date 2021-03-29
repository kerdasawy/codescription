import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CodeModuleEntryComponent } from './code-module-entry.component';

describe('CodeModuleEntryComponent', () => {
  let component: CodeModuleEntryComponent;
  let fixture: ComponentFixture<CodeModuleEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CodeModuleEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CodeModuleEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
