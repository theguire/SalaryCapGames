google.charts.load('current', { 'packages': ['corechart'] });
google.charts.setOnLoadCallback(generateChart); 

function generateChart() {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Products');
    data.addColumn('number', 'Sales');
    data.addRows([
        ['Tofu', 30],
        ['Chai', 10],
        ['Chocolade', 20],
        ['Ipoh Coffee', 40]
    ]);

    var options = {
        'title': 'Quarterly Sales',
        'width': 600,
        'height': 300,
        is3D: true,
        colors: ['#d9534f', '#f0ad4e', '#5bc0de', '#5cb85c']
    };

    var chart = new google.visualization.PieChart($('#piechart')[0]);
    chart.draw(data, options);
} 