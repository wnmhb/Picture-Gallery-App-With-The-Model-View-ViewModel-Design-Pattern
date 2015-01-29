using System.Linq;
using System.Collections.Generic;
using System.Windows.Input;
using WpfApplication1.ServiceReference1;
using System.ComponentModel;

namespace WpfApplication1
{
    public class PageViewModel : INotifyPropertyChanged
    {
        Service1Client client;

        public PageViewModel() {
            client = new Service1Client();
            
            PageCount = client.GetPageCount(PageSize);
            PictureDataList = client.GetPageData(CurrentPage, PageSize).ToList();
        }

        private int pageCol = 4;
        /// <summary>
        /// the column of every page
        /// </summary>
        public int PageCol {
            get {
                return pageCol;
            }
            set {
                pageCol = value;
                OnPropertyChanged("PageCol");
                OnPropertyChanged("PageSize");
            }
        }

        private int pageRow = 2;
        /// <summary>
        /// the row of every page
        /// </summary>
        public int PageRow {
            get
            {
                return pageRow;
            }
            set
            {
                pageRow = value;
                OnPropertyChanged("PageRow");
                OnPropertyChanged("PageSize");
            }
        }

        /// <summary>
        /// page size
        /// </summary>
        public int PageSize {
            get
            {
                return PageCol * PageRow;
            }
        }

        private int currentPage = 0;
        /// <summary>
        /// current page index
        /// </summary>
        public int CurrentPage {
            get
            {
                return currentPage;
            }
            set
            {
                currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }

        private int pageCount = 0;
        /// <summary>
        /// page count
        /// </summary>
        public int PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
                OnPropertyChanged("PageCount");
            }
        }

        private List<PictureData> pictureDataList;
        /// <summary>
        /// current page data
        /// </summary>
        public List<PictureData> PictureDataList {
            get {
                return pictureDataList;
            }
            set {
                pictureDataList = value;
                OnPropertyChanged("PictureDataList");
            }
        }

        private ICommand prePageCommand;

        /// <summary>
        /// Event command:go to previous page
        /// </summary>
        public ICommand PrePageCommand
        {
            get
            {
                if (prePageCommand == null)
                    prePageCommand = new DelegateCommand(
                        () =>
                        {
                            CurrentPage--;
                            PictureDataList = client.GetPageData(CurrentPage, PageSize).ToList();
                        },
                        () =>
                        {
                            return CurrentPage > 0;
                        });
                return prePageCommand;
            }
        }

        private ICommand nextPageCommand;

        /// <summary>
        /// Event command:go to next page
        /// </summary>
        public ICommand NextPageCommand
        {
            get
            {
                if (nextPageCommand == null)
                    nextPageCommand = new DelegateCommand(
                        () =>
                        {
                            CurrentPage++;
                            PictureDataList = client.GetPageData(CurrentPage, PageSize).ToList();
                        },
                        () =>
                        {
                            return CurrentPage < PageCount - 1;
                        });
                return nextPageCommand;
            }
        }

        private ICommand gotoPageCommand;

        /// <summary>
        /// Event command:go to specified page
        /// </summary>
        public ICommand GotoPageCommand
        {
            get
            {
                if (gotoPageCommand == null)
                    gotoPageCommand = new DelegateCommand<string>(
                        (pram) =>
                        {
                            int toPage = int.Parse(pram);
                            if (toPage - 1 != CurrentPage && toPage >= 1 && toPage <= PageCount)
                            {
                                CurrentPage = toPage - 1;
                                PictureDataList = client.GetPageData(CurrentPage, PageSize).ToList();
                            }
                        },
                        (pram) =>
                        {
                            return true;
                        });
                return gotoPageCommand;
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
