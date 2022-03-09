import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpgradetextComponent } from './upgradetext.component';

describe('UpgradetextComponent', () => {
  let component: UpgradetextComponent;
  let fixture: ComponentFixture<UpgradetextComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpgradetextComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpgradetextComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
