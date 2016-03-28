console.log('Hello world');

var edge = require('edge');

var objDLL2 = edge.func({
	
	assemblyFile: 'Gw2MumbleLink.dll',
	
	typeName: 'Gw2MumbleLink.MainClass',
	
	methodName: 'test'

});

objDLL2('objDLL2', function (error, result) {
	if (error) throw error;
	console.log(result);
});

var objDLL = edge.func({
	
	assemblyFile: 'Gw2MumbleLink.dll',
	
	typeName: 'Gw2MumbleLink.MainClass',
	
	methodName: 'Init'

});

objDLL('objDLL', function (error, result) {
	if (error) throw error;
	console.log(result);
});

var objDLL2 = edge.func({
	
	assemblyFile: 'Gw2MumbleLink.dll',
	
	typeName: 'Gw2MumbleLink.MainClass',
	
	methodName: 'test'

});

objDLL2('objDLL2', function (error, result) {
	if (error) throw error;
	console.log(result);
});

console.log('End world');