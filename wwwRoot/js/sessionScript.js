/* 
 * sessionScript.js, 210808
 * Author: Russell Fisher
   create utility test for Sission Id and other stuff
 */

const bdy = document.querySelector('body');
bdy.addEventListener('onload', sayHello);

function checkSession() // 
{
    console.log("checkSession function")
    let para = document.createElement('p');
    para.textContent = 'new paragraph';
    bdy.appendChild(para);
    
}

function sayHello()
{
    console.log("Say Hello On Load");
}