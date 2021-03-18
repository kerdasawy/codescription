import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CodeTypeEntryComponent } from './code-type-entry.component';

describe('CodeTypeEntryComponent', () => {
  let component: CodeTypeEntryComponent;
  let fixture: ComponentFixture<CodeTypeEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CodeTypeEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CodeTypeEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
