﻿// <auto-generated />
using System;
using Diagnosticos.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diagnosticos.Persistence.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221029113412_CheckModel")]
    partial class CheckModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Diagnosticos")
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Diagnosticos.Domain.DetalleDiagnostico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Diagnostico_Id")
                        .HasColumnType("int");

                    b.Property<int>("Pregunta_Id")
                        .HasColumnType("int");

                    b.Property<string>("Respuesta")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Diagnostico_Id");

                    b.ToTable("DetallesDiagnosticos", "Diagnosticos");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Diagnostico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Especialidad_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Paciente_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Especialidad_Id");

                    b.ToTable("Diagnosticos", "Diagnosticos");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Enfermedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CantidadSintomas")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("NombreClave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tratamiento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enfermedades", "Diagnosticos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CantidadSintomas = 5,
                            Descripcion = "Infección viral común que puede ser mortal, especialmente en grupos de alto riesgo.",
                            Nombre = "Gripe",
                            NombreClave = "gripe",
                            Tratamiento = "La gripe se trata principalmente con descanso y líquidos para que el cuerpo pueda combatir la infección por sí solo. Los analgésicos antiinflamatorios de venta libre pueden ayudar con los síntomas. Una vacuna anual puede prevenir la gripe y limitar sus complicaciones."
                        },
                        new
                        {
                            Id = 2,
                            CantidadSintomas = 6,
                            Descripcion = "Es una enfermedad infecciosa causada por un virus de la influenza tipo A. Su morbilidad suele ser alta y su mortalidad baja.",
                            Nombre = "Gripe A",
                            NombreClave = "gripeA",
                            Tratamiento = "Se recomienda el uso de oseltamivir o zanamivir para la prevención y el tratamiento de la infección por los virus de la influenza porcina"
                        },
                        new
                        {
                            Id = 3,
                            CantidadSintomas = 5,
                            Descripcion = "Insuficiencia de glóbulos rojos saludables debido a la falta de hierro en el cuerpo.",
                            Nombre = "Anemia",
                            NombreClave = "anemia",
                            Tratamiento = "Utilizar factores de crecimiento como la eritropoyetina permite tratar con gran eficacia muchas formas de anemia. En caso de riesgo de vida, son importantes las transfusiones de concentrados de hematíes provenientes de donaciones."
                        },
                        new
                        {
                            Id = 4,
                            CantidadSintomas = 4,
                            Descripcion = "Infección viral contagiosa que se puede prevenir con una vacuna y es conocida por su característico sarpullido rojo.",
                            Nombre = "Rubéola",
                            NombreClave = "rubeola",
                            Tratamiento = "Si bien no hay ningún tratamiento para eliminar una infección establecida, los medicamentos pueden contrarrestar los síntomas. La vacunación puede ayudar a prevenir la enfermedad."
                        },
                        new
                        {
                            Id = 5,
                            CantidadSintomas = 5,
                            Descripcion = "Enfermedad viral transmitida por los mosquitos y de prevalencia en las áreas tropicales y subtropicales.",
                            Nombre = "Dengue",
                            NombreClave = "dengue",
                            Tratamiento = "El tratamiento incluye la ingesta de líquidos y el uso de analgésicos. Los casos más graves requieren atención hospitalaria."
                        },
                        new
                        {
                            Id = 6,
                            CantidadSintomas = 4,
                            Descripcion = "Infección que inflama los sacos de aire de uno o ambos pulmones, los que pueden llenarse de fluido.",
                            Nombre = "Neumonía",
                            NombreClave = "neumonia",
                            Tratamiento = "Los antibióticos permiten tratar varios tipos de neumonía y algunos pueden prevenirse mediante vacunas."
                        },
                        new
                        {
                            Id = 7,
                            CantidadSintomas = 7,
                            Descripcion = "La enfermedad por coronavirus (COVID‑19) es una enfermedad infecciosa provocada por el virus SARS-CoV-2.",
                            Nombre = "COVID‑19",
                            NombreClave = "covid",
                            Tratamiento = "Para proporcionar unos cuidados óptimos, se necesita oxígeno para los pacientes que se encuentran más graves; en pacientes críticos, se requieren respiradores."
                        });
                });

            modelBuilder.Entity("Diagnosticos.Domain.Especialidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Especialidades", "Diagnosticos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Es la rama de la medicina que se especializa en la salud y las enfermedades de los niños. Se trata de una especialidad médica que se centra en los pacientes desde el momento del nacimiento hasta la adolescencia.",
                            Nombre = "Pediatría"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "La cardiología es la rama de la medicina que se encarga del estudio, diagnóstico y tratamiento de las enfermedades del corazón y del aparato circulatorio.",
                            Nombre = "Cardiología"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Es la especialidad médica que se ocupa de las enfermedades del aparato digestivo y órganos asociados, conformado por: esófago, estómago, hígado y vías biliares, páncreas, intestino delgado (duodeno, yeyuno, íleon), colon y recto. El médico que practica esta especialidad se llama gastroenterólogo o especialista en aparato digestivo.",
                            Nombre = "Gastroenterología"
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Por motivos de prueba.",
                            Nombre = "General"
                        });
                });

            modelBuilder.Entity("Diagnosticos.Domain.Opcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Pregunta_Id")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Pregunta_Id");

                    b.ToTable("Opciones", "Diagnosticos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Pregunta_Id = 1,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 2,
                            Pregunta_Id = 1,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 3,
                            Pregunta_Id = 2,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 4,
                            Pregunta_Id = 2,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 5,
                            Pregunta_Id = 3,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 6,
                            Pregunta_Id = 3,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 7,
                            Pregunta_Id = 4,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 8,
                            Pregunta_Id = 4,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 9,
                            Pregunta_Id = 5,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 10,
                            Pregunta_Id = 5,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 11,
                            Pregunta_Id = 6,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 12,
                            Pregunta_Id = 6,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 13,
                            Pregunta_Id = 7,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 14,
                            Pregunta_Id = 7,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 15,
                            Pregunta_Id = 8,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 16,
                            Pregunta_Id = 8,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 17,
                            Pregunta_Id = 9,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 18,
                            Pregunta_Id = 9,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 19,
                            Pregunta_Id = 10,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 20,
                            Pregunta_Id = 10,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 21,
                            Pregunta_Id = 11,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 22,
                            Pregunta_Id = 11,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 23,
                            Pregunta_Id = 12,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 24,
                            Pregunta_Id = 12,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 25,
                            Pregunta_Id = 13,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 26,
                            Pregunta_Id = 13,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 27,
                            Pregunta_Id = 14,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 28,
                            Pregunta_Id = 14,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 29,
                            Pregunta_Id = 15,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 30,
                            Pregunta_Id = 15,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 31,
                            Pregunta_Id = 16,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 32,
                            Pregunta_Id = 16,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 33,
                            Pregunta_Id = 17,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 34,
                            Pregunta_Id = 17,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 35,
                            Pregunta_Id = 18,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 36,
                            Pregunta_Id = 18,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 37,
                            Pregunta_Id = 19,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 38,
                            Pregunta_Id = 19,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 39,
                            Pregunta_Id = 20,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 40,
                            Pregunta_Id = 20,
                            Valor = "No"
                        },
                        new
                        {
                            Id = 41,
                            Pregunta_Id = 21,
                            Valor = "Sí"
                        },
                        new
                        {
                            Id = 42,
                            Pregunta_Id = 21,
                            Valor = "No"
                        });
                });

            modelBuilder.Entity("Diagnosticos.Domain.PosibleEnfermedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Diagnostico_Id")
                        .HasColumnType("int");

                    b.Property<int>("Enfermedad_Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Porcentaje")
                        .HasPrecision(4, 1)
                        .HasColumnType("decimal(4,1)");

                    b.HasKey("Id");

                    b.HasIndex("Diagnostico_Id");

                    b.HasIndex("Enfermedad_Id");

                    b.ToTable("PosiblesEnfermedades", "Diagnosticos");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Pregunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Especialidad_Id")
                        .HasColumnType("int");

                    b.Property<string>("PalabraClave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TieneOpciones")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Especialidad_Id");

                    b.ToTable("Preguntas", "Diagnosticos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Contenido = "¿Tiene una sensación de temperatura alta en el cuerpo?",
                            Especialidad_Id = 4,
                            PalabraClave = "fiebre",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 2,
                            Contenido = "¿Tiene una sensación generalizada de molestia?",
                            Especialidad_Id = 4,
                            PalabraClave = "malestargeneral",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 3,
                            Contenido = "¿Sufre de dolor de garganta?",
                            Especialidad_Id = 4,
                            PalabraClave = "dolorgarganta",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 4,
                            Contenido = "¿Tiene dolor de cabeza? (ya sea, leve o moderado)",
                            Especialidad_Id = 4,
                            PalabraClave = "dolorcabeza",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 5,
                            Contenido = "¿Tiene la nariz tapada (congestionada)?",
                            Especialidad_Id = 4,
                            PalabraClave = "congestionnasal",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 6,
                            Contenido = "¿Sufre de tos con flema?",
                            Especialidad_Id = 4,
                            PalabraClave = "tos",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 7,
                            Contenido = "¿Sufre de dolor y malestar en los músculos (ya sea, moderado o intenso)?",
                            Especialidad_Id = 4,
                            PalabraClave = "dolormuscular",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 8,
                            Contenido = "¿No tuvo apetito en los últimos 2 días?",
                            Especialidad_Id = 4,
                            PalabraClave = "perdidaapetito",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 9,
                            Contenido = "¿Ha sufrido de nauseas en las últimas 24 horas?",
                            Especialidad_Id = 4,
                            PalabraClave = "nauseas",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 10,
                            Contenido = "¿Ha vomitado en las últimas horas?",
                            Especialidad_Id = 4,
                            PalabraClave = "vomito",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 11,
                            Contenido = "¿Se siente cansado y sin ganas de hacer nada?",
                            Especialidad_Id = 4,
                            PalabraClave = "cansancio",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 12,
                            Contenido = "¿Tiene dificultad para respirar adecuadamente?",
                            Especialidad_Id = 4,
                            PalabraClave = "dificultadrespirar",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 13,
                            Contenido = "¿Tiene una sensación de tener frío y temblores a pesar de no estar en un lugar frío?",
                            Especialidad_Id = 4,
                            PalabraClave = "escalofrios",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 14,
                            Contenido = "¿Tiene los ojos más rojos de lo habitual?",
                            Especialidad_Id = 4,
                            PalabraClave = "ojosrojos",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 15,
                            Contenido = "¿Sufre de brotes temporales de parches de piel enrojecidos, bultos, escamas y picazón?",
                            Especialidad_Id = 4,
                            PalabraClave = "erupcionespiel",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 16,
                            Contenido = "¿Sufre de dolor en las articulaciones?",
                            Especialidad_Id = 4,
                            PalabraClave = "dolorarticulacion",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 17,
                            Contenido = "¿Tiene malestar, dolor leve, ardor o agobio en el pecho?",
                            Especialidad_Id = 4,
                            PalabraClave = "dolorpecho",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 18,
                            Contenido = "¿Tiene tos que regresa constanmente cada pocos minutos?",
                            Especialidad_Id = 4,
                            PalabraClave = "tosconstante",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 19,
                            Contenido = "¿Tiene una temperatura corporal muy alta con escalofríos constantes?",
                            Especialidad_Id = 4,
                            PalabraClave = "fiebreescalofrios",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 20,
                            Contenido = "¿Ha perdido sensibilidad en el gusto y no siente olores a su alrededor?",
                            Especialidad_Id = 4,
                            PalabraClave = "perdidagustoolfato",
                            TieneOpciones = true
                        },
                        new
                        {
                            Id = 21,
                            Contenido = "¿Sufre de tos sin flema (tos seca)?",
                            Especialidad_Id = 4,
                            PalabraClave = "tosseca",
                            TieneOpciones = true
                        });
                });

            modelBuilder.Entity("Diagnosticos.Domain.DetalleDiagnostico", b =>
                {
                    b.HasOne("Diagnosticos.Domain.Diagnostico", "Diagnostico")
                        .WithMany("DetallesDiagnostico")
                        .HasForeignKey("Diagnostico_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diagnosticos.Domain.Pregunta", "Pregunta")
                        .WithMany("DetallesDiagnosticos")
                        .HasForeignKey("Diagnostico_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnostico");

                    b.Navigation("Pregunta");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Diagnostico", b =>
                {
                    b.HasOne("Diagnosticos.Domain.Especialidad", "Especialidad")
                        .WithMany("Diagnosticos")
                        .HasForeignKey("Especialidad_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Especialidad");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Opcion", b =>
                {
                    b.HasOne("Diagnosticos.Domain.Pregunta", "Pregunta")
                        .WithMany("Opciones")
                        .HasForeignKey("Pregunta_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pregunta");
                });

            modelBuilder.Entity("Diagnosticos.Domain.PosibleEnfermedad", b =>
                {
                    b.HasOne("Diagnosticos.Domain.Diagnostico", "Diagnostico")
                        .WithMany("PosiblesEnfermedades")
                        .HasForeignKey("Diagnostico_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diagnosticos.Domain.Enfermedad", "Enfermedad")
                        .WithMany("PosiblesEnfermedades")
                        .HasForeignKey("Enfermedad_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnostico");

                    b.Navigation("Enfermedad");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Pregunta", b =>
                {
                    b.HasOne("Diagnosticos.Domain.Especialidad", "Especialidad")
                        .WithMany("Preguntas")
                        .HasForeignKey("Especialidad_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidad");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Diagnostico", b =>
                {
                    b.Navigation("DetallesDiagnostico");

                    b.Navigation("PosiblesEnfermedades");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Enfermedad", b =>
                {
                    b.Navigation("PosiblesEnfermedades");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Especialidad", b =>
                {
                    b.Navigation("Diagnosticos");

                    b.Navigation("Preguntas");
                });

            modelBuilder.Entity("Diagnosticos.Domain.Pregunta", b =>
                {
                    b.Navigation("DetallesDiagnosticos");

                    b.Navigation("Opciones");
                });
#pragma warning restore 612, 618
        }
    }
}
