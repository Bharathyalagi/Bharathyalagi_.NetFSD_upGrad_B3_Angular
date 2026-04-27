import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

  public uname: string = "";
  public message: string = "";

  public loginClick(): void {

    if (this.uname.trim() !== "") {
      this.message = "Welcome " + this.uname;
    }
    else {
      this.message = "User not defined";
    }

  }

}