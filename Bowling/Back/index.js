var mysql = require('mysql')
var express = require('express')

var connection = mysql.createConnection({
    host: "localhost" , // address of the server
    user: "root" , // username
    password: "12345" ,
    database: "bowling",
  });
  
const port = 8080;
const app = express();

app.use(express.json());

connection.connect(function(err) {
    if (err) {
      console.error('🔒 error connecting: ' + err.stack);
      return;
    }
    console.log('🧬 connected as id ' + connection.threadId + ' 🔓');
  });

  // HOME ROUTE
app.get("/", (req, res) => {
    res.send("Welcome 🥷🏽");
  });
  // GET ALL PLAYERS
app.get('/player', (req, res ) => {
  connection.query('SELECT * FROM player', (err, results) => {
    if(err){
      res.status(500).send('Error retrieving data');
      console.log(err)
    }else {
      res.status(200).json(results)
    }
  })
});
//GET ALL SCORES
app.get('/score', (req, res ) => {
  connection.query('SELECT * FROM score', (err, results) => {
    if(err){
      res.status(500).send('Error retrieving data');
      console.log(err)
    }else {
      res.status(200).json(results)
    }
  })
});

  app.listen(port, () => {
    console.log(` ⚙️.📟  Server is running on port : ${port} ✅`);
  })