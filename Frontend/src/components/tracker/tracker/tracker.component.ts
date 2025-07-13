import { Component, inject, OnInit } from '@angular/core';
import { TrackerService } from '../../../services/tracker/tracker.service'
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-tracker',
  templateUrl: './tracker.component.html',
  styleUrls: ['./tracker.component.css'],
  standalone: true,
  imports: [CommonModule],

})
export class TrackerComponent implements OnInit {

  trackerService = inject(TrackerService)
  http = inject(HttpClient)


  constructor() { }

  ngOnInit() {
    this.trackerService.getTracker().subscribe(r => {
      console.log(r)
    })
  }


}
