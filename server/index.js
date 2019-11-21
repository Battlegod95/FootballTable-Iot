var restify = require('restify');

var server = restify.createServer();
server.use(restify.plugins.bodyParser());

server.get('/tables', function(req, res, next) {
    res.send('List of tables: [TODO]');
    return next();
});

server.get('/tables/:serial', function(req, res, next) {
    res.send('Current values for table ' + req.params['serial'] + ': [TODO]');
    return next();
});

server.post('/tables/:serial', function(req, res, next) {
    
    res.send('Data received from table [TODO]');



    // uncomment to see posted data
    console.log(req.body);

    return next();
});

server.listen(8011, function() {
    console.log('%s listening at %s', server.name, server.url);
});


