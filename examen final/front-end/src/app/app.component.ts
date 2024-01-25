import { Component, OnInit } from '@angular/core';
import { DataService } from './data-service.service';
import { HttpClientModule } from '@angular/common/http';
import { NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [HttpClientModule, NgFor, NgIf],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  profesori: any[] = [];
  materii: any[] = [];

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    this.dataService.getProfesori().subscribe(
      data => this.profesori = data,
    );

    this.dataService.getMaterii().subscribe(
      data => this.materii = data,
    );
  }
}
