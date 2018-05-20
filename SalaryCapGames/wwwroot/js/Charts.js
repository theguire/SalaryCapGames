
var ctx6 = document.getElementById("myChart6");
var myChart6 = new Chart(ctx6, {
    type: 'bar',
    data: {
        labels: ["6/24", "6/25", "6/26", "6/27", "6/28", "6/29", "6/30"],
        datasets: [{
            data: [25, 10, 30, 21, 17, 30, 14],
            lineTension: 0,
            backgroundColor: 'transparent',
            borderColor: '#007bff',
            borderWidth: 4,
            pointBackgroundColor: '#007bff',
            fillColor: "rgba(220,220,220,0.2)",
            strokeColor: "rgba(220,220,220,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(220,220,220,1)",
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        },
        legend: {
            display: false,
        }
    }
});

var ctx5 = document.getElementById("myChart5");
var myChart5 = new Chart(ctx5, {
    type: 'bar',
    data: {
        labels: ["6/24", "6/25", "6/26", "6/27", "6/28", "6/29", "6/30"],
        datasets: [{
            data: [25, 10, 30, 21, 17, 30, 14],
            lineTension: 0,
            backgroundColor: 'transparent',
            borderColor: '#007bff',
            borderWidth: 4,
            pointBackgroundColor: '#007bff',
            fillColor: "rgba(220,220,220,0.2)",
            strokeColor: "rgba(220,220,220,1)",
            pointStrokeColor: "#fff",
            pointHighlightFill: "#fff",
            pointHighlightStroke: "rgba(220,220,220,1)",
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        },
        legend: {
            display: false,
        }
    }
});
