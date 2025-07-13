import { Component, inject, OnInit } from '@angular/core';
import { TrackerService } from '../../../services/tracker/tracker.service'

@Component({
  selector: 'app-tracker',
  templateUrl: './tracker.component.html',
  styleUrls: ['./tracker.component.css']
})
export class TrackerComponent implements OnInit {

  trackerService = inject(TrackerService)


  constructor() { }

  ngOnInit() {
    this.trackerService.getTracker().subscribe(r => {
      console.log(r)
    })
  }

}
