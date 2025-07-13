import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TrackerComponent } from '../components';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, TrackerComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'daily-tracker';
}
