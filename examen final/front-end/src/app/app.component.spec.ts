import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';
import { of } from 'rxjs';

import { AppComponent } from './app.component';
import { DataService } from './data-service.service';

describe('AppComponent', () => {
  let fixture: ComponentFixture<AppComponent>;
  let app: AppComponent;
  let dataService: jasmine.SpyObj<DataService>;

  beforeEach(() => {
    const dataServiceSpy = jasmine.createSpyObj('DataService', ['getProfesori']);

    TestBed.configureTestingModule({
      declarations: [AppComponent],
      imports: [HttpClientModule],
      providers: [{ provide: DataService, useValue: dataServiceSpy }]
    });

    fixture = TestBed.createComponent(AppComponent);
    app = fixture.componentInstance;
    dataService = TestBed.inject(DataService) as jasmine.SpyObj<DataService>;
  });

  it('should create the app', () => {
    expect(app).toBeTruthy();
  });

  it('should fetch and display profesori', () => {
    const profesoriData = [{ name: 'Profesor 1' }, { name: 'Profesor 2' }];
    dataService.getProfesori.and.returnValue(of(profesoriData));

    fixture.detectChanges();

    expect(dataService.getProfesori).toHaveBeenCalled();
    expect(app.profesori).toEqual(profesoriData);
  });
});
