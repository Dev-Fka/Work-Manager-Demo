import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import Work from '../Model/Work';

@Component({
  selector: 'app-completed-task',
  templateUrl: './completed-task.component.html',
  styleUrls: ['./completed-task.component.css']
})
export class CompletedTaskComponent implements OnInit {

  works:Work[]=[];
  succeededWorks:Work[]=[];

  constructor(private http:HttpClient) { }
  
  ngOnInit(): void {
    this.getValues().subscribe(data=>{
      this.works=data
      this.works.forEach(work => {
        if(work.isSucceeded){
          this.succeededWorks.push(work)
        }
      });
    })
  }

  getValues(){
   return this.http.get<Work[]>('https://workmanagerdemorest.azurewebsites.net/work');
  }
}
