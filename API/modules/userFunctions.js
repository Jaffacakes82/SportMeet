var mysql = require('mysql');
var config = require('config');
var crypto = require('../modules/cryptoFunctions.js');

var connection = mysql.createConnection({
    host: config.get('dbConfig.host'),
    user: config.get('dbConfig.username'),
    password: crypto.decrypt(config.get('dbConfig.password')),
    database: config.get('catalogue')
})

module.exports = {
    registerUser: function () {
        //...
    },
    loginUser: function () {

    }
}
