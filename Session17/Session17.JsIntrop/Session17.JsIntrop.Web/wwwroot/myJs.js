function saymessage(message) {
    alert("say hello show your message: " + message);
}
function logPerson(person) {
    console.log(person);
}

function callstatic() {
    DotNet.invokeMethodAsync('Session17.JsIntrop.Web', 'LogStatic');
}


function callinstance(myclassInstance) {
    myclassInstance.invokeMethodAsync('LogInstance');
}