import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewSpriteChoiceComponent } from './new-sprite-choice.component';

describe('NewSpriteChoiceComponent', () => {
  let component: NewSpriteChoiceComponent;
  let fixture: ComponentFixture<NewSpriteChoiceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewSpriteChoiceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewSpriteChoiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
