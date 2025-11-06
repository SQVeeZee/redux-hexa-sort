using Project.Progress;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Project
{
    public class GameLifetimeScope : LifetimeScope
    {
        [Header("levels")]
        [SerializeField]
        private LevelsConfig _levelsConfig;

        [Header("board")]
        [SerializeField]
        private BoardAssetConfig _boardAssetConfig;
        [SerializeField]
        private TileAssetConfig _tileAssetConfig;
        [SerializeField]
        private CellsAssetConfig _cellsAssetConfig;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<ModuleController>();

            RegisterCore(builder);
            RegisterLevel(builder);
        }

        private void RegisterCore(IContainerBuilder builder)
        {
        }

        private void RegisterLevel(IContainerBuilder builder)
        {
            builder.Register<LevelService>(Lifetime.Singleton);
            builder.Register<ProgressManager>(Lifetime.Singleton);
            builder.RegisterInstance(_levelsConfig);

            //builder
            builder.Register<LevelBuilder>(Lifetime.Singleton);
            builder.Register<BoardBuilder>(Lifetime.Singleton);
            builder.Register<CellsBuilder>(Lifetime.Singleton);
            builder.Register<TilesBuilder>(Lifetime.Singleton);

            //context
            builder.Register<LevelContext>(Lifetime.Singleton).AsImplementedInterfaces();

            //configs
            builder.RegisterInstance(_boardAssetConfig);
            builder.RegisterInstance(_cellsAssetConfig);
            builder.RegisterInstance(_tileAssetConfig);

            //factory
            builder.Register<BoardFactory>(Lifetime.Singleton);
            builder.Register<CellsFactory>(Lifetime.Singleton);
            builder.Register<TilesFactory>(Lifetime.Singleton);
        }
    }
}
