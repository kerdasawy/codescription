import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CodeModuleListComponent } from './code-module-list.component';

describe('CodeModuleListComponent', () => {
  let component: CodeModuleListComponent;
  let fixture: ComponentFixture<CodeModuleListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CodeModuleListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CodeModuleListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
