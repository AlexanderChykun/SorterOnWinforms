using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorterer;
using System.Threading;

namespace WinFormsSorter
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Конструктор инициализирующий компоненты формы
        /// </summary>
        public Form1 ()
        {
            InitializeComponent ();
        }
        /// <summary>
        /// обработчик события: загрузка виндовс формы
        /// </summary>
        /// <param name="sender">объект инициатор события</param>
        /// <param name="e">параметры события</param>
        private void Form1_Load ( object sender, EventArgs e )
        {
            tbEnterArr.Enabled = true;
            tbNumOfElems.Enabled = false;
            gbOptions.Enabled = false;

        }
        /// <summary>
        /// Обработчик события установки флажка выбора способы ввода
        /// </summary>
        /// <param name="sender">объект инициатор события</param>
        /// <param name="e">параметры события</param>
        private void chkbxChooseEnteringMethod_CheckedChanged ( object sender, EventArgs e )
        {
            if ( chkbxChooseEnteringMethod.Checked )
            {
                tbEnterArr.Enabled = false;
                tbNumOfElems.Enabled = true;
            }
            else
            {
                tbEnterArr.Enabled = true;
                tbNumOfElems.Enabled = false;
            }
        }
        /// <summary>
        /// Обработчик клика кнопки Apply
        /// </summary>
        /// <param name="sender">объект инициатор события</param>
        /// <param name="e">параметры события</param>
        private void btnApply_Click ( object sender, EventArgs e )
        {
            if ( chkbxChooseEnteringMethod.Checked  )
            {
                 Random rnd = new Random();
            
                _arr = new double[Convert.ToInt32(tbNumOfElems.Text)];

                for (int i = 0; i < _arr.Length; i++)
                {
                    _arr[i] = Math.Round(rnd.NextDouble() + rnd.Next(100),2);
                }
                }
            else
            {
                string [] arr = tbEnterArr.Text.Split ( ' ' );
                _arr = new double[arr.Length];
                for ( int i = 0; i < _arr.Length; i++ )
                {
                    _arr[i] = Convert.ToInt32( arr[i] );
                }
            }
            gbOptions.Enabled = true;
            rBtnBubble.Checked = false;
            rBtnCoctail.Checked = false;
            rBtnHeap.Checked = false;
            rBtnInsert.Checked = false;
            rBtnQuick.Checked = false;
            rBtnShell.Checked = false;
            tbSortedArr.Text = null;
        }
        /// <summary>
        /// Обработчик клика кнопки SORT
        /// </summary>
        /// <param name="sender">объект инициатор события</param>
        /// <param name="e">параметры события</param>
        private void btnSort_Click ( object sender, EventArgs e )
        {
            _SwapCount = 0;
            _CompareCount = 0;

            _sort.Run ();
            for ( int i = 0; i < _arr.Length; i++ )
            {
                tbSortedArr.Text += string.Format ( "{0}  ",_sort.GetArrCopy()[i] );
            }
            gbOptions.Enabled = false;
            tbNumOfElems.Text = null;
            _arr = null;
            lblStartSort.Text = null;
            label3.Text = null;
            label4.Text = null;
            label6.Text = null;
            label7.Text = null;
        }
        /// <summary>
        /// Обработчик события старта сортировки
        /// </summary>
        /// <param name="o">объект инициатор события</param>
        /// <param name="arg">параметры события</param>
        public void StartSortMessage ( object o, SortingEventArgs arg )
        {
            lblStartSort.Text = string.Format ( "Стартовала " + o.ToString () + " сортировка" );
            lblStartSort.Update ();
        }
        /// <summary>
        /// Обработчик события обмена элементов
        /// </summary>
        /// <param name="o">объект инициатор события</param>
        /// <param name="arg">параметры события</param>
        public void SwapCounting ( object o, SwapSorterEventArgs arg )
        {
            label3.Text = string.Format ( "a[ i ]: {0,5}", arg.FirstArg );
            label3.Update ();
            label4.Text = string.Format ( "a[ j ]: {0,5}", arg.SecondArg );
            label4.Update ();
            _SwapCount++;
            Thread.Sleep ( 500);
        }
        /// <summary>
        /// Обработчик события сравнения элементов
        /// </summary>
        /// <param name="o">объект инициатор события</param>
        /// <param name="arg">параметры события</param>
        public void CompareCounting ( object o, SwapSorterEventArgs arg )
        {
            label6.Text = string.Format ( "a[ i ]: {0,5}", arg.FirstArg );
            label6.Update ();
            label7.Text = string.Format ( "a[ j ]: {0,5}", arg.SecondArg );
            label7.Update ();
            _CompareCount++;
            Thread.Sleep ( 500 );
        }
        /// <summary>
        /// Обработчик события окончания сортировки
        /// </summary>
        /// <param name="o">объект инициатор события</param>
        /// <param name="arg">параметры события</param>
        public void FinishSortMessage ( object o, EventArgs arg )
        {
            MessageBox.Show ( "Закончилась сортировка:\nСовершено " + _SwapCount + " перестановок\nСовершено " + _CompareCount + " сравнений" );
        }
        /// <summary>
        /// Обработчик события установки флажка на Bubble sorter
        /// </summary>
        /// <param name="sender">объект инициатор события<</param>
        /// <param name="e">параметры события</param>
        private void rBtnBubble_CheckedChanged ( object sender, EventArgs e )
        {
            if ( rBtnBubble.Checked )
            {
                _sort = new BubbleSorter ( _arr );
                _sort.SortingStart += StartSortMessage;
                _sort.Swapp += SwapCounting;
                _sort.Compare += CompareCounting;
                _sort.SortingFin += FinishSortMessage;
            }
            else
            {
                _sort = null;
            }
        }
        /// <summary>
        /// Обработчик события установки флажка на Coctail sorter
        /// </summary>
        /// <param name="sender">объект инициатор события<</param>
        /// <param name="e">параметры события</param>
        private void rBtnCoctail_CheckedChanged ( object sender, EventArgs e )
        {
            if ( rBtnCoctail.Checked )
            {
                _sort = new CoctailSorter ( _arr );
                _sort.SortingStart += StartSortMessage;
                _sort.Swapp += SwapCounting;
                _sort.Compare += CompareCounting;
                _sort.SortingFin += FinishSortMessage;
            }
            else
            {
                _sort = null;
            }
        }
        /// <summary>
        /// Обработчик события установки флажка на Heap sorter
        /// </summary>
        /// <param name="sender">объект инициатор события<</param>
        /// <param name="e">параметры события</param>
        private void rBtnHeap_CheckedChanged ( object sender, EventArgs e )
        {
            if ( rBtnHeap.Checked )
            {
                _sort = new HeapSorter ( _arr );
                _sort.SortingStart += StartSortMessage;
                _sort.Swapp += SwapCounting;
                _sort.Compare += CompareCounting;
                _sort.SortingFin += FinishSortMessage;
            }
            else
            {
                _sort = null;
            }
        }
        /// <summary>
        /// Обработчик события установки флажка на Insert sorter
        /// </summary>
        /// <param name="sender">объект инициатор события<</param>
        /// <param name="e">параметры события</param>
        private void rBtnInsert_CheckedChanged ( object sender, EventArgs e )
        {
            if ( rBtnInsert.Checked )
            {
                _sort = new InsertSorter ( _arr );
                _sort.SortingStart += StartSortMessage;
                _sort.Swapp += SwapCounting;
                _sort.Compare += CompareCounting;
                _sort.SortingFin += FinishSortMessage;
            }
            else
            {
                _sort = null;
            }
        }
        /// <summary>
        /// Обработчик события установки флажка на Quick sorter
        /// </summary>
        /// <param name="sender">объект инициатор события<</param>
        /// <param name="e">параметры события</param>
        private void rBtnQuick_CheckedChanged ( object sender, EventArgs e )
        {
            if ( rBtnQuick.Checked )
            {
                _sort = new QuickSorter ( _arr );
                _sort.SortingStart += StartSortMessage;
                _sort.Swapp += SwapCounting;
                _sort.Compare += CompareCounting;
                _sort.SortingFin += FinishSortMessage;
            }
            else
            {
                _sort = null;
            }
        }
        /// <summary>
        /// Обработчик события установки флажка на Shell sorter
        /// </summary>
        /// <param name="sender">объект инициатор события<</param>
        /// <param name="e">параметры события</param>
        private void rBtnShell_CheckedChanged ( object sender, EventArgs e )
        {
            if ( rBtnShell.Checked )
            {
                _sort = new ShellSorter ( _arr );
                _sort.SortingStart += StartSortMessage;
                _sort.Swapp += SwapCounting;
                _sort.Compare += CompareCounting;
                _sort.SortingFin += FinishSortMessage;
            }
            else
            {
                _sort = null;
            }
        }
        /// <summary>
        /// переменная типа sorter
        /// </summary>
        private Sorter _sort;
        /// <summary>
        /// Массив исходных данных
        /// </summary>
        private double[] _arr;
        /// <summary>
        /// счетчик обмена элементов
        /// </summary>
        private uint _SwapCount = 0;
        /// <summary>
        /// счетчик сравнения элементов
        /// </summary>
        private uint _CompareCount = 0;

    }
}
