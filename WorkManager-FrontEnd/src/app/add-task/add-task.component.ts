import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import Work from '../Model/Work';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent implements OnInit {

  constructor(private http:HttpClient) { }
  httpOptions = {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
  }
  work:Work=new Work();
  isAdded:boolean=false;
  ngOnInit(): void {
  }
  
  sendWork(w:Work):boolean{
    
    if(this.work.name==null || this.work.description==null || (this.work.isMonthly==false || this.work.isWeekly==false || this.work.isDaily==false)){
        return this.isAdded;
    }else{
      console.log('running')
      this.http.post<Work>('https://workmanagerdemorest.azurewebsites.net/work',JSON.stringify(this.work),this.httpOptions)
                  .subscribe(res=> {
                    if(res!=null){
                      this.isAdded=true;
                    }
                    
                  });
                  w.name='';
                  w.description='';
                  w.isDaily=false;
                  w.isMonthly=false;
                  w.isWeekly=false;
                  return this.isAdded;
    }
    
  }

  getAlert(x:boolean):String{
    return (this.isAdded ? "mt-3 alert alert-success text-center":"visually-hidden")
  }

  
}
