var crypto = require('crypto');
var bcrypt = require('bcrypt-nodejs');
var config = require('config');
var ALGORITHM = 'AES-256-CTR';
var HMAC_ALGORITHM = 'SHA256';


module.exports = {
    encrypt: function (data) {
        var key = config.get('cryptoKey');
        var cipher = crypto.createCipher(ALGORITHM, key);
        var encrypted = cipher.update(data, 'utf8', 'hex') + cipher.final('hex');

        return encrypted;
    },
    decrypt: function (data) {
        var key = config.get('cryptoKey');
        var decipher = crypto.createDecipher(ALGORITHM, key);
        var decrypted = decipher.update(data, 'hex', 'utf8') + decipher.final('utf8');

        return decrypted;
    },
    hash: function (data) {

    }
}
