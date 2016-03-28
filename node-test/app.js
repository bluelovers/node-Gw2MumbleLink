console.log('Hello world');

var edge = require('edge');

var objDLL = edge.func({
	
	assemblyFile: 'Gw2MumbleLink.dll',
	
	typeName: 'Gw2MumbleLink.MainClass',
	
	methodName: 'test'

});

objDLL('objDLL', function (error, result) {
	if (error) throw error;
	console.log(result);
});

console.log('End world');