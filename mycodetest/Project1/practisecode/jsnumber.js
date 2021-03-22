var x=12;
var txt="";

while(x!=Infinity)
{
    x=x*x;
    txt+=x+"<br>";

}
document.write(txt);

var num=123;
document.write(num.toString(2)+"<br>");
document.write(num.toString(3));

document.write("<br>");

var x=1233;
document.write(x.toString()+"<br>");  //number represent as string 


var y=890.234;
document.write(y.toFixed(0)+"<br>");

document.write(y.toFixed(3)+"<br>");     //tofixed method 

document.write(y.toPrecision()+"<br>");
document.write(y.toPrecision(5)+"<br>")  //number lenth specific by precisoon method 

document.write(Number("123")+"<br>");   //convert to number

document.write(Number(false)+"<br>")

document.write(Number.MAX_VALUE+"<br>")






