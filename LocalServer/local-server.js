var nodeStatic = require("node-static");

const port = 9000;
const folder = "./www";
var file = new nodeStatic.Server(folder);


require("http").createServer((req,res) =>
	req.addListener("end",() => file.serve(req,res)).resume()
).listen(port);


console.log(".  Listening on :  http://127.0.0.1:"+port+"/");