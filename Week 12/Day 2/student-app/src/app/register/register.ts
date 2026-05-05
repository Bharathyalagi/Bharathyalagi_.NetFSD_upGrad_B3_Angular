import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './register.html'
})
export class RegisterComponent {

  student = { name:'', email:'' };

  constructor(private service:StudentService){}

  submit(){
    console.log("clicked");
    this.service.register(this.student).subscribe(res=>{
      console.log(res);
      this.student = { name:'', email:'' };
    });
  }
}