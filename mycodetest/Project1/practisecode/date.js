var d=new Date();
document.write(d.getDate());
document.write("<br>"+d);
document.write("<br>"+d.getTime());
d.setFullYear(2023);
document.write("<br>"+d.getFullYear());
document.write("<br>"+Math.ceil(3.5));

document.write("<br>"+Math.min(12,4,56,31));

var a=12;
document.write("<br>"+Boolean(a));
var b=true;
var c=new Boolean(false);

document.write("<br>"+(b==c));

var d=12;
if(d>12)
{
    document.write("<br>"+"the greather number ");

}
else
{
    document.write("<br>"+"the smaller number");

}

var text=(d==12)?"equal number":"not equal number";

document.write("<br>"+text);

var a=1;
document.write("<br>"+ ++a  );
document.write("<br>"+ a);
document.write("<br>"+ a++);
document.write("<br>"+a);
var b=123;


document.write("<br>"+b.toString(16));  //converting number 
var str="md sumon mia";
var n=str.search("mia");
document.write("<br>"+n);









