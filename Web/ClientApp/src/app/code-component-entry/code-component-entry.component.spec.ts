import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CodeComponentEntryComponent } from './code-component-entry.component';

describe('CodeComponentEntryComponent', () => {
  let component: CodeComponentEntryComponent;
  let fixture: ComponentFixture<CodeComponentEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CodeComponentEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CodeComponentEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
