import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import Work from '../Model/Work';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {

  constructor(private http:HttpClient) { }

  values:Work[]=[];
  task:Work=new Work();
  ngOnInit(): void {
    this.getValues().subscribe(data=>{this.values=data
    });
    
  }

  calculateDay(work:Work,time:any):any{
    let today:any=new Date();
    let startDate:any=new Date(time)
    var dif=Math.floor((today - startDate) / (1000 * 60 * 60 * 24));
    if(work.isDaily && work.isMonthly && work.isWeekly){
      return '~'
    }
    if(work.isDaily && work.isWeekly){
      return '~'
    }
    if(work.isMonthly && work.isWeekly){
      return '~'
    }
    if(work.isMonthly){
      let remainingDay=30-dif;
      return remainingDay;
    }
    if(work.isWeekly){
      let remaingDay=7-dif;
      return remaingDay;
    }
    if(work.isDaily){
      let remainingDay=2-dif;
      return remainingDay;
    }
  }
  

  getValues(){
    return this.http.get<Work[]>('https://workmanagerdemorest.azurewebsites.net/work');
  }

  setSucceeded(work:Work){
    work.isSucceeded=true;
    this.http.put('https://workmanagerdemorest.azurewebsites.net/work'+'/'+work.id,work)
            .subscribe(res=>{
            console.log(res)
    });
  }

  deleteWork(work:Work){
    this.http.delete('https://workmanagerdemorest.azurewebsites.net/work'+'/'+work.id)
              .subscribe(res=>{
                let index=this.values.indexOf(work);
                this.values.splice(index,1);
              })
  }

}
