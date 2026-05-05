import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-courses',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './courses.html'
})
export class CoursesComponent implements OnInit{

  courses:any;

  constructor(private service:StudentService){}

  ngOnInit(){
    this.service.getCourses().subscribe(res=>{
      this.courses = res;
    });
  }
}