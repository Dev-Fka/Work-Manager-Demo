export default class Work{
    constructor(
       public id?:number,
       public name?:string,
       public description?:string,
       public isMonthly?:boolean,
       public isWeekly?:boolean,
       public isDaily?:boolean,
       public isSucceeded?:boolean,
       public addedTime?:Date
    ){}
    

}