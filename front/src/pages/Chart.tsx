import React from 'react';
import Breadcrumb from '../components/Breadcrumbs/Breadcrumb';
import ChartOne from '../components/Charts/ChartOne';
import ChartThree from '../components/Charts/ChartThree';

const Chart: React.FC = () => {
  return (
    <>
      <Breadcrumb pageName="Statistika" />

      <div className="flex gap-4 md:gap-6 2xl:gap-7.5">
        <div className="flex-1">
          <ChartOne />
        </div>
        <div className="flex-1">
          <ChartThree />
        </div>
      </div>
    </>
  );
};

export default Chart;
