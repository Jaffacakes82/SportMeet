var mysql = require('mysql');
var config = require('config');
var crypto = require('../modules/cryptoFunctions.js');

var connection = mysql.createConnection({
    host: config.get('dbConfig.host'),
    user: config.get('dbConfig.username'),
    password: crypto.decrypt(config.get('dbConfig.password')),
    database: config.get('dbConfig.catalogue')
})

module.exports = {
    registerUser: function (toRegister, callback) {
        connection.connect();

        var toPersist = {
            Id: toRegister.Id,
            Username: toRegister.Username,
            PasswordHash: crypto.hash(toRegister.Password),
            EmailAddress: toRegister.EmailAddress,
            FirstName: toRegister.FirstName,
            LastName: toRegister.LastName
        };

        connection.query('SELECT 1 FROM user WHERE Username = ?', [toPersist.Username], function (err, results) {
            if (err) {
                console.warn(err);
                callback(false);
            }

            if (results.length > 0) {
                console.log('user already exists')
                callback(false);
            } else {
                connection.query('INSERT INTO user SET ?', toPersist, function (err, result) {
                    if (err) {
                        console.warn(err);
                        callback(false);
                    }

                    console.log(result);
                    callback(true);
                });
            }
        });

        connection.end();
    },
    loginUser: function (toLogin, callback) {
        connection.connect();

        var toFetch = {
            Username: toLogin.Username,
            Password: toLogin.Password
        };

        connection.query('SELECT * FROM user WHERE Username = ?', [toFetch.Username], function (err, results) {
            if (err) {
                console.warn(err);
                callback({
                    authToken: '',
                    success: false
                })
            }

            if (results.length == 0) {
                console.log('no user found matching username');
                callback({
                    authToken: '',
                    success: false
                });
            }

            console.log(result);
        });
    }
}
