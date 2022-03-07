import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SaveLogoutComponent } from './save-logout.component';

describe('SaveLogoutComponent', () => {
  let component: SaveLogoutComponent;
  let fixture: ComponentFixture<SaveLogoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SaveLogoutComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SaveLogoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
