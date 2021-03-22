var counter=0;
for(var i=0;i<5;i++)
{
  counter=counter+2;
  window.setTimeout(myf,100);
}
function myf()
{
    console.log(counter);
   // document.write(counter);

}
console.log("my name is sumon");
