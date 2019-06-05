using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public GroupBehavior GroupBehaviors { get; set; }
        public MainPage()
        {
            InitializeComponent();
            GroupBehaviors = new GroupBehavior
            {
                Description = "Grupo 1",
                Behaviors = new List<Behavior>()
                    {
                        new Behavior
                        {
                            Description = "Actitud",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 2",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 3",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 4",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 5",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 6",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 7",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 8",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 9",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 10",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 11",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 12",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 13",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 14",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 15",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        },
                        new Behavior
                        {
                            Description = "Actitud 16",
                            Levels = new List<Level>
                            {
                                new Level
                                {
                                    Description="Nivel 1 - Texto para mostrar si el carrusel funciona bien dentro de una lista 1"
                                },
                                new Level
                                {
                                    Description="Nivel 2 - Texto para mostrar si el carrusel funciona bien dentro de una lista 2"
                                },
                                new Level
                                {
                                    Description="Nivel 3 - Texto para mostrar si el carrusel funciona bien dentro de una lista 3"
                                },
                                new Level
                                {
                                    Description="Nivel 4 - Texto para mostrar si el carrusel funciona bien dentro de una lista 4"
                                }
                            }
                        }
                    }
            };

            //listExample.bin
            BindableLayout.SetItemsSource(listExample, GroupBehaviors.Behaviors);
        }
    }
}
